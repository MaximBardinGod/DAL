import { Form, Button, FormGroup, FormLabel } from "react-bootstrap";
import "./style.css";

function FormRegister() {
  return (
    <Form className="form">
      <FormGroup>
        <FormLabel>Пол</FormLabel>
        <Form.Select aria-label="Default select example">
          <option value="1">Мужской</option>
          <option value="2">Женский</option>
        </Form.Select>
      </FormGroup>

      <Form.Group className="mb-3" controlId="formBasicEmail">
        <Form.Label>Email</Form.Label>
        <Form.Control type="email" placeholder="Enter email" />
      </Form.Group>

      <Form.Group className="mb-3" controlId="formBasicPassword">
        <Form.Label>Password</Form.Label>
        <Form.Control type="password" placeholder="Password" />
      </Form.Group>
      <Button variant="primary" type="submit">
        Начать
      </Button>
    </Form>
  );
}

export default FormRegister;
