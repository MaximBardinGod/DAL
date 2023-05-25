import React, { Component } from "react";
import { Button, Form } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";

export class FormRegister extends Component {
  static displayName = FormRegister.name;

  constructor(props) {
    super(props);
    this.state = {
      nameProduct: "",
      countProtein: "",
      countUglevod: "",
      countFat: "",
    };

    this.onInputChange = this.onInputChange.bind(this);
    this.sendProductData = this.sendProductData.bind(this);
  }

  onInputChange(event) {
    this.setState({
      [event.target.name]: event.target.value,
    });
  }

  render() {
    return (
      <div>
        <h1 style={{ padding: "10px" }}>Форма для заполнения продукта</h1>

        <Form style={{ padding: "10px" }}>
          <div class="form-row">
            <div class="form-group col-md-6">
              <label for="inputName">Name</label>
              <input
                type="text"
                class="form-control"
                id="inputName"
                placeholder=""
                value={this.state.nameProduct}
                name="nameProduct"
                onChange={this.onInputChange}
              />
            </div>
          </div>
          <div class="form-group col-md-6">
            <label for="inputProtein">Count protein</label>
            <input
              type="text"
              class="form-control"
              id="inputProtein"
              placeholder=""
              value={this.state.countProtein}
              name="countProtein"
              onChange={this.onInputChange}
            />
          </div>
          <div class="form-row">
            <div class="form-group col-md-6">
              <label for="inputUglevod">Count uglevod</label>
              <input
                type="text"
                class="form-control"
                id="inputUglevod"
                placeholder=""
                value={this.state.countUglevod}
                name="countUglevod"
                onChange={this.onInputChange}
              />
            </div>
          </div>
          <div class="form-row">
            <div class="form-group col-md-6">
              <label for="inputFat">Count fat</label>
              <input
                type="text"
                class="form-control"
                id="inputFat"
                placeholder=""
                value={this.state.countFat}
                name="countFat"
                onChange={this.onInputChange}
              />
            </div>
          </div>

          <Button
            variant="success"
            class="f-button "
            style={{ marginTop: "10px" }}
            onClick={this.sendProductData}
          >
            {" "}
            Success
          </Button>
        </Form>
      </div>
    );
  }

  async sendProductData() {
    let product = {
      name: this.state.nameProduct,
      countProtein: this.state.countProtein,
      countUglevod: this.state.countUglevod,
      countFat: this.state.countFat,
    };
    console.log(product);

    const reponse = await fetch("/api/Domain/Product", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(product),
    });

    const data = await reponse.json();
    console.log(data);
  }
}
export default FormRegister;
