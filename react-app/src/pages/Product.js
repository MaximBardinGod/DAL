import { Component } from "react";
import Table from "react-bootstrap/Table";

//let response = await fetch("/api/Domain/Product");
//let commits = await response.json();
//alert(response.headers.get("Content-Type"));

export default class Products extends Component

function StripedColumnsExample() {
  return (
    <Table striped="columns">
      <thead>
        <tr>
          <th>#</th>
          <th>Name</th>
          <th>Protein</th>
          <th>Fat</th>
          <th>Ugl</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>1</td>
          <td>Mark</td>
          <td>Otto</td>
          <td>@mdo</td>
        </tr>
      </tbody>
    </Table>
  );
}

export default StripedColumnsExample;
