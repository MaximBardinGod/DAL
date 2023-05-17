import axios from "axios";
import { useEffect, useState } from "react";
import {
  Form,
  Table,
  Button,
  FormControl,
} from "react-bootstrap";

export default function Product() {
  const [data, setData] = useState([]);

  const [name,setName] = useState('')
  const [tempValue, setTempValue] = useState('');

  const handleButtonClick = () => {
    setTempValue(name);
  };

  const params = {
    name: name,
  };
  
  const queryString = params
    ? Object.keys(params)
        .map((key) => `${encodeURIComponent(key)}=${encodeURIComponent(params[key])}`)
        .join('&')
    : '';

  const baseUrl = '/api/Domain/Product/ProductList';

  const url = queryString ? `${baseUrl}?${queryString}` : baseUrl;

  useEffect(() => {
    const fetchData = async() => {
      const response = await axios.get(url)

      setData(response.data)
    }
    fetchData()
  }, [tempValue]);



  return (
    <div>
      <h1>Products:</h1>
      <Table striped bordered hover variant="dark" style={{ width: 600 }}>
        <thead>
          <tr>
            <th>Name</th>
            <th>Count protein</th>
            <th>Count fat</th>
            <th>Count Carbohydrate</th>
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
        <h3>Filter</h3>
        <input
          type="text" 
          placeholder="Enter name" 
          style={{width:200}} 
          value={name}
          onChange={event => setName(event.target.value)}
        />
        <Button onClick={handleButtonClick}>Find</Button>
      </div>
    </div>
  );
}
