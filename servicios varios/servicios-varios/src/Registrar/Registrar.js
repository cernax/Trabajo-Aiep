import React from 'react';
import Card from 'react-bootstrap/Card';
import Image from "react-bootstrap/Image";
import Form from 'react-bootstrap/Form';
import Row from "react-bootstrap/Row";
import Col from "react-bootstrap/Col";
import Modal from "react-bootstrap/Modal";
import Button from "react-bootstrap/Button";

function Registrar() {
    return (
        <div className="App">
            <br />
            <Card>
                <Card.Header>
                    <div>
                        Nuevo Usuario
                    </div>
                </Card.Header>
                <Card.Body>
                    <div style={{width:'20%'}}>
                        <Form>
                            <div style={{textAlign:'left'}}>
                                <Form.Group controlId="formTitulo">
                                    <Form.Label>Nombre</Form.Label>
                                    <Form.Control type="text" placeholder="Ingrese Nombre" />
                                </Form.Group>
                                <Form.Group controlId="formPrecio">
                                    <Form.Label>Direccion</Form.Label>
                                    <Form.Control type="text" placeholder="Ingrese Direccion" />
                                </Form.Group>
                                <Form.Group controlId="formCorreo">
                                    <Form.Label>Correo</Form.Label>
                                    <Form.Control type="text" placeholder="Ingrese Correo" />
                                </Form.Group>
                                <Form.Group controlId="formContacto">
                                    <Form.Label>Numero Contacto</Form.Label>
                                    <Form.Control type="text" placeholder="Numero Contacto" />
                                </Form.Group>
                                <Form.Group>
                                    <Form.File id="exampleFormControlFile1" label="Adjuntar Imagen Perfil" />
                                </Form.Group>
                                <Form.Group controlId="exampleForm.Usuario">
                                    <Form.Label>Tipo de Usuario</Form.Label>
                                    <Form.Control as="select">
                                        <option>Necesito Servicio</option>
                                        <option>Ofresco Servicio</option>
                                    </Form.Control>
                                </Form.Group>
                                {['radio'].map((type) => (
                                    <div key={`inline-${type}`} className="mb-3">
                                        <Form.Check inline label="Tatuador" type={type} id={`inline-${type}-1`} />
                                        <Form.Check inline label="Fotografo" type={type} id={`inline-${type}-2`} />
                                        <Form.Check inline label="Maestro Constructor" type={type} id={`inline-${type}-3`} />
                                    </div>
                                ))}
                                <Button variant="primary" type="submit">
                                    Guardar
                                </Button>
                            </div>
                        </Form>
                    </div>
                </Card.Body>
            </Card>
        </div>
    );
}

export default Registrar;

