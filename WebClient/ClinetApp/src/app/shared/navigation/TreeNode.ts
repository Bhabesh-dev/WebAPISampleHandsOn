import { BehaviorSubject } from "rxjs";

export class TreeNode {
  children: BehaviorSubject<TreeNode[]>;
  constructor(
    public item: string,
    children?: TreeNode[],
    public parent?: TreeNode
  ) {
    this.children = new BehaviorSubject(children === undefined ? [] : children);
  }
}

export const TREE_DATA = [
  new TreeNode("Categoty", [
    new TreeNode("Books", [
      new TreeNode("Exception"),
      new TreeNode("Exclusion"),
      new TreeNode("Specal request")
    ]),
    new TreeNode("Misc", [
      new TreeNode("node1"),
      new TreeNode("node2"),
      new TreeNode("node3")
    ]),
    new TreeNode("Music", [
      new TreeNode("node1"),
      new TreeNode("node2"),
      new TreeNode("node3")
    ])
  ])
];
