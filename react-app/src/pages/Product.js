import { useEffect, useState } from "react";
import {
  Form,
  Table,
  DropdownButton,
  Dropdown,
  Button,
} from "react-bootstrap";

export default function Product() {
  const [data, setData] = useState([]);
  const [id,setId] = useState(1)

  useEffect(() => {
    fetch("/api/Domain/Product")
      .then((res) => res.json())
      .then((res) => {
        setData(res);
      });
  }, []);



  return (
    <div>
      <h1>Products:</h1>
      <Table striped bordered hover variant="dark" style={{ width: 600 }}>
        <thead>
          <tr>
            <th>Name</th>
            <th>Count protein</th>
            <th>Count fat</th>
            <th>Count uglevod</th>
          </tr>
        </thead>
        <tbody>
          {data.map((post) => {
            return (
              <tr>
                <td style={{ color: "#1e925e" }}>{post.name}</td>
                <td>{post.countProtein}</td>
                <td>{post.countFat}</td>
                <td>{post.countUgl}</td>
              </tr>
            );
          })}
        </tbody>
      </Table>
      <div style={{}}>
        <h3>Фильтр</h3>
        <Form.Control 
          id="id" 
          type="id" 
          placeholder="Enter id" 
          style={{width:200}} 
          value={id}
          onChange={event => setId(event.target.value)}
        />
        <Button href="/product/{id}">Найти</Button>
      </div>
    </div>
  );
}
