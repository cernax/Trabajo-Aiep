import React, {useState} from 'react';
import Card from 'react-bootstrap/Card';
import Image from "react-bootstrap/Image";
import Form from 'react-bootstrap/Form';
import Row from "react-bootstrap/Row";
import Col from "react-bootstrap/Col";
import Container from "react-bootstrap/Container";
import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";

function Servicios() {

    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return (
        <div className="App">
            <br />
            <Card>
                <Card.Header>
                        <div style={{width:'100%'}}>
                            <Row>
                                <div style={{textAlign:'left'}}>
                                    <Image width={'50em'} src="https://mdbootstrap.com/img/Photos/Avatars/avatar-1.jpg" roundedCircle />&nbsp;Fotografo
                                </div>
                                <div  style={{textAlign:'right', width:'95%'}}>
                                    <Button variant="primary" onClick={handleShow}>
                                        Cargar Trabajo
                                    </Button>
                                </div>
                            </Row>
                        </div>
                </Card.Header>
            </Card>
                <Row>
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="https://mdbootstrap.com/img/Photos/Slides/img%20(1).jpg" />
                        <Card.Body>
                            <Card.Title>Paisaje N°1</Card.Title>
                            <Card.Text>
                                Precio: $100.000
                            </Card.Text>
                            <Button variant="primary">Pedir</Button>
                        </Card.Body>
                    </Card>
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="https://mdbootstrap.com/img/Photos/Slides/img%20(2).jpg" />
                        <Card.Body>
                            <Card.Title>Paisaje N°2</Card.Title>
                            <Card.Text>
                                Precio: $300.000
                            </Card.Text>
                            <Button variant="primary">Pedir</Button>
                        </Card.Body>
                    </Card>
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="https://mdbootstrap.com/img/Photos/Slides/img%20(3).jpg" />
                        <Card.Body>
                            <Card.Title>Paisaje N°3</Card.Title>
                            <Card.Text>
                                Precio: $200.000
                            </Card.Text>
                            <Button variant="primary">Pedir</Button>
                        </Card.Body>
                    </Card>
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="https://mdbootstrap.com/img/Photos/Slides/img%20(4).jpg" />
                        <Card.Body>
                            <Card.Title>Paisaje N°4</Card.Title>
                            <Card.Text>
                                Precio: $150.000
                            </Card.Text>
                            <Button variant="primary">Pedir</Button>
                        </Card.Body>
                    </Card>
                </Row>

            <Modal show={show} onHide={handleClose} animation={false}>
                <Modal.Header closeButton>
                    <Modal.Title>Agregar Nuevo Trabajo</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Form>
                        <Form.Group controlId="formTitulo">
                            <Form.Label>Titulo</Form.Label>
                            <Form.Control type="text" placeholder="Ingrese Titulo" />
                        </Form.Group>
                        <Form.Group controlId="formPrecio">
                            <Form.Label>Precio</Form.Label>
                            <Form.Control type="text" placeholder="Ingrese Precio" />
                        </Form.Group>
                        <Form.Group>
                            <Form.File id="exampleFormControlFile1" label="Adjuntar Imagen" />
                        </Form.Group>
                    </Form>
                </Modal.Body>
                <Modal.Footer>
                    <Button variant="primary" onClick={handleClose}>
                        Guardar
                    </Button>
                    <Button variant="secondary" onClick={handleClose}>
                        Cerrar
                    </Button>
                </Modal.Footer>
            </Modal>
        </div>
    );
}

export default Servicios;

