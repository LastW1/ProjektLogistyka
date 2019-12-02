import json

import matplotlib.pyplot as plt
import networkx as nx
# import pygraphviz

G = nx.DiGraph()


def test():
    G.add_edge('a', 'b', weight=0.6)
    G.add_edge('a', 'c', weight=0.2)
    G.add_edge('c', 'd', weight=0.1)
    G.add_edge('c', 'e', weight=0.7)
    G.add_edge('c', 'f', weight=0.9)
    G.add_edge('a', 'd', weight=0.3)

    elarge = [(u, v) for (u, v, d) in G.edges(data=True) if d['weight'] > 0.5]
    esmall = [(u, v) for (u, v, d) in G.edges(data=True) if d['weight'] <= 0.5]

    pos = nx.spring_layout(G)  # positions for all nodes

    # nodes
    nx.draw_networkx_nodes(G, pos, node_size=700)

    # edges
    nx.draw_networkx_edges(G, pos, edgelist=G.edges(data=True),
                           width=6)
    # nx.draw_networkx_edges(G, pos, edgelist=esmall,
    #                        width=6, alpha=0.5, edge_color='b', style='dashed')

    # labels
    nx.draw_networkx_labels(G, pos, font_size=20, font_family='sans-serif')
    print(nx.algorithms.dag_longest_path(G))
    plt.axis('off')
    # plt.show()
    print(G.nodes)


def thingy():
    def filter_edge(n1, n2):
        return G[n1][n2]['weight'] - G[n1][n2]['weightMax']
    limiter = None
    with open("ObiektList.json", "r") as file:
        dict = json.load(file)
        # print(dic)
        limiter = dict['czasDocelowy']
        for edge in dict['krawedzie']:
            try:
                cost_gradient = (edge['kosztGraniczny'] - edge['kosztNormalny']) / (
                            edge['czasNormalny'] - edge['czasGraniczny'])
            except ZeroDivisionError:
                cost_gradient = None
            G.add_edge(edge['poprzednie'], edge['nastepne'], weight=edge['czasNormalny'],
                       weightMax=edge['czasGraniczny'], cost=edge['kosztNormalny'], costMax=edge['kosztGraniczny'],
                       costGradient=cost_gradient)

    print(nx.algorithms.dag_longest_path_length(G))
    changed = True
    while changed:
        changed = False
        if nx.algorithms.dag_longest_path_length(G) <= limiter:
            break
        crit_path = G.subgraph(nx.algorithms.dag_longest_path(G))
        # for edge in crit_path.edges:
        #     print(G[edge[0]][edge[1]])
        # print('\n\n')
        view = nx.subgraph_view(crit_path, filter_edge=filter_edge)
        if view.edges:
            # for edge in view.edges:
            #     print(G[edge[0]][edge[1]])
            zxc = sorted(view.edges(data=True), key=lambda x: x[2]['costGradient'])
            n1, n2, _ = zxc[0]
            # print(n1,n2)
            G[n1][n2]['weight'] -= 1
            G[n1][n2]['cost'] += G[n1][n2]['costGradient']
            changed = True
            # for n1, n2, data in view.edges(data=True):
            #     print(n1,n2, data)
    print(nx.algorithms.dag_longest_path_length(G))

    # while limiter > 0:
    #     longest_path = nx.algorithms.dag_longest_path(G)
    #     print(longest_path)
    #     print(G.subgraph(longest_path).edges)
    #     # elegitimate_optimisation_edges = [x for x in ]
    #     while longest_path == nx.algorithms.dag_longest_path(G):
    #         pass
    #
    #
    #     limiter-=1
    #     pass

    pos = nx.spring_layout(G)  # positions for all nodes
    # pos = nx.nx_agraph.graphviz_layout(G, prog='neato')
    pos_label = {}
    for k, v in pos.items():
        pos_label[k] = (v[0], v[1] + 1)

    # nodes
    nx.draw_networkx_nodes(G, pos, node_size=700)

    # edges
    nx.draw_networkx_edges(G, pos, edgelist=G.edges(data=True),
                           width=6)
    # nx.draw_networkx_edges(G, pos, edgelist=esmall,
    #                        width=6, alpha=0.5, edge_color='b', style='dashed')

    # labels
    nx.draw_networkx_labels(G, pos, font_size=20, font_family='sans-serif')
    edge_labels = {(u, v): data['weight'] for u, v, data in G.edges(data=True)}
    nx.draw_networkx_edge_labels(G, pos, font_size=20, font_family='sans-serif', edge_labels=edge_labels)
    plt.axis('off')
    # plt.show()
    plt.savefig('graph.png')


thingy()
