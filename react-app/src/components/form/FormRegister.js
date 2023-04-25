import React, {Component} from "react";
import { Button, Modal, Form, input } from "react-bootstrap";
import 'bootstrap/dist/css/bootstrap.min.css';


export class FormRegister extends Component{
render() {
  return{
    <><h1 style={{ padding: "10px" }}>Форма для заполнения</h1><Form style={{ padding: "10px" }}>
      <div class="form-row">
        <div class="form-group col-md-6">
          <label for="inputName">Name</label>
          <input
            type="Name"
            class="form-control"
            id="inputFIO"
            placeholder="" />
        </div>
      </div>
      <div class="form-group col-md-6">
        <label for="inputLogin">Login</label>
        <input
          type="text"
          class="form-control"
          id="inputLogin" />
      </div>
      <div class="form-row">
        <div class="form-group col-md-6">
          <label for="inputPassword">Password</label>
          <input type="text" class="form-control" id="inputINN" />
        </div>
      </div>

      <Button variant="success" class="f-button " style={{ marginTop: "10px" }}>
        {" "}
        Success
      </Button>
    </Form></>
  };
}
};
export default FormRegister;
