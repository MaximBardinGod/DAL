import React, { Component } from "react";
import { Button, Modal, Form, input } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";

export class FormRegister extends Component {
  static displayName = FormRegister.name;

  constructor(props) {
    super(props);
    this.state = {
      nameClient: "",
      login: "",
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
      <div>
        <h1 style={{ padding: "10px" }}>Форма для заполнения</h1>

        <Form style={{ padding: "10px" }}>
          <div class="form-row">
            <div class="form-group col-md-6">
              <label for="inputName">Name</label>
              <input
                type="Name"
                class="form-control"
                id="inputName"
                placeholder=""
              />
            </div>
          </div>
          <div class="form-group col-md-6">
            <label for="inputLogin">Login</label>
            <input type="text" class="form-control" id="inputLogin" />
          </div>
          <div class="form-row">
            <div class="form-group col-md-6">
              <label for="inputPassword">Password</label>
              <input type="text" class="form-control" id="inputINN" />
            </div>
          </div>

          <Button
            variant="success"
            class="f-button "
            style={{ marginTop: "10px" }}
          >
            {" "}
            Success
          </Button>
        </Form>
      </div>
    );
  }

  async sendClientData() {
    let client = {
      NameClient: this.state.nameClient,
      Login: this.state.login,
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