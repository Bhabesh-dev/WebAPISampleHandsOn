import { Component, OnInit, ChangeDetectorRef } from "@angular/core";
import { TreeNode, TREE_DATA } from "./TreeNode";

import { NestedTreeControl } from "@angular/cdk/tree";
import { MatTreeNestedDataSource } from "@angular/material/tree";

@Component({
  selector: "app-navigation",
  templateUrl: "./navigation.component.html",
  styleUrls: ["./navigation.component.css"]
})
export class NavigationComponent implements OnInit {
  levels = new Map<TreeNode, number>();
  treeControl: NestedTreeControl<TreeNode>;

  dataSource: MatTreeNestedDataSource<TreeNode>;

  constructor(private changeDetectorRef: ChangeDetectorRef) {
    this.treeControl = new NestedTreeControl<TreeNode>(this.getChildren);
    this.dataSource = new MatTreeNestedDataSource();
    this.dataSource.data = TREE_DATA;
  }

  getChildren = (node: TreeNode) => {
    return node.children;
  };
  hasChildren = (index: number, node: TreeNode) => {
    return node.children.value.length > 0;
  };

  ngOnInit(): void {}
}
