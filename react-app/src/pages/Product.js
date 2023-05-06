import { useEffect, useState } from "react";
import {
  Table,
  Form,
  InputGroup,
  SplitButton,
  Dropdown,
} from "react-bootstrap";

export default function Product() {
  const [data, setData] = useState([]);

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
      <div>
        <h3>Фильтр</h3>
        <InputGroup className="mb-3">
          <SplitButton
            variant="outline-secondary"
            title="Action"
            id="segmented-button-dropdown-1"
          >
            <Dropdown.Item href="#">Name</Dropdown.Item>
            <Dropdown.Item href="#">Count protein</Dropdown.Item>
            <Dropdown.Item href="#">Count fat</Dropdown.Item>
            <Dropdown.Item href="#">Count uglevod</Dropdown.Item>
            <Dropdown.Divider />
          </SplitButton>
          <Form.Control aria-label="Text input with dropdown button" />
        </InputGroup>
      </div>
    </div>
  );
}
