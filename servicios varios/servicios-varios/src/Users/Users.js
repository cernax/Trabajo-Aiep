import React from 'react';
import Card from 'react-bootstrap/Card';
import Image from "react-bootstrap/Image";
import Form from 'react-bootstrap/Form';
import Row from "react-bootstrap/Row";
import Col from "react-bootstrap/Col";

function Users() {
    return (
        <div className="App">
            <br />
            <Card>
                <Card.Header>
                    <div style={{textAlign:'left'}}>
                        <Image width={'50em'} src="https://mdbootstrap.com/img/Photos/Avatars/avatar-1.jpg" roundedCircle />&nbsp;Andres Corro
                    </div>
                </Card.Header>
                <Card.Body>
                    <Form>
                        <Form.Group as={Row} controlId="formPlaintextEmail">
                            <Form.Label column sm="2">
                                Email
                            </Form.Label>
                            <Col sm="10">
                                <Form.Control plaintext readOnly defaultValue="email@example.com" />
                            </Col>
                        </Form.Group>
                        <Form.Group as={Row} controlId="formDireccion">
                            <Form.Label column sm="2">
                                Direccion
                            </Form.Label>
                            <Col sm="10">
                                <Form.Control plaintext readOnly defaultValue="calle falsa 123" />
                            </Col>
                        </Form.Group>
                        <Form.Group as={Row} controlId="formContacto">
                            <Form.Label column sm="2">
                                N° de Telefono
                            </Form.Label>
                            <Col sm="10">
                                <Form.Control plaintext readOnly defaultValue="12345678" />
                            </Col>
                        </Form.Group>
                    </Form>
                </Card.Body>
            </Card>
        </div>
    );
}

export default Users;

