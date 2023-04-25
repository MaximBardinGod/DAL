import { Form, Button, FormGroup, FormLabel, FormCheck } from "react-bootstrap";
import React, { Component } from "react";
import "./style.css";
import "bootstrap/dist/css/bootstrap.min.css";
import { render } from "@testing-library/react";

export class FormRegister extends Comment {
  static displayName = FormRegister.name;

  constructor(props) {
    super(props);
    this.state = {
      gender: "",
      name: "",
      email: "",
      password: "",
    };

    this.onInputChange = this.onInputChange.bind(this);
    this.sendClientData = this.sendClientData.bind(this);
  }

  onInputChange(event) {
    this.setState({
      [event.target.name]: event.target.value,
    });
  }

  render() {
    return (
      <div className="box-form">
        <Form className="form">
          <FormGroup>
            <FormLabel>Gender</FormLabel>
            <Form.Select
              aria-label="Default select example"
              onInput={this.state.gender}
            >
              <option value="1">Male</option>
              <option value="2">Female</option>
            </Form.Select>
          </FormGroup>

          <Form.Group className="mb-3" controlId="formBasicName">
            <Form.Label>Name</Form.Label>
            <Form.Control
              type="Name"
              placeholder="Name"
              onInput={this.state.name}
            />
          </Form.Group>

          <Form.Group className="mb-3" controlId="formBasicEmail">
            <Form.Label>Email</Form.Label>
            <Form.Control
              type="email"
              placeholder="Enter email"
              onInput={this.state.email}
            />
          </Form.Group>

          <Form.Group className="mb-3" controlId="formBasicPassword">
            <Form.Label>Password</Form.Label>
            <Form.Control
              type="password"
              placeholder="Password"
              onInput={this.state.email}
            />
          </Form.Group>
          <Form.Group className="mb-3">
            <Form.Check
              type="checkbox"
              label="I have read and agree to the user agreement"
            />
          </Form.Group>
          <Button variant="success" type="submit">
            submit
          </Button>
        </Form>
      </div>
    );
  }
  async sendClientData() {
    let client = {
      Gender: this.state.gender,
      Name: this.state.name,
      Email: this.state.email,
      Password: this.state.password,
    };
    console.log(client);

    const reponse = await fetch(
      "https://localhost:7134/api/admin/client/create",
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Basic dGVzdDp0ZXN0Mg==",
        },
        body: JSON.stringify(client),
      }
    );

    const data = await reponse.json();
    console.log(data);
  }
}
