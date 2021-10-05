import React from 'react';
import Card from 'react-bootstrap/Card';
import Image from "react-bootstrap/Image";
import Form from 'react-bootstrap/Form';
import Row from "react-bootstrap/Row";
import Col from "react-bootstrap/Col";
import App from "../App";
import Button from "react-bootstrap/Button";

function Home() {
    return (
        <div className="App">
            <Form.Group>
                <div style={{width:'65%', paddingLeft:'35%'}} >
                    <Form.Control size="lg" type="text" placeholder="Buscador" />
                </div>
            </Form.Group>
            <hr />
            <div>
                <Row>
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="https://mdbootstrap.com/img/Photos/Slides/img%20(1).jpg" />
                        <Card.Body>
                            <Card.Title>Paisaje N°1</Card.Title>
                            <Card.Text>
                                <span> Nombre: Juanito</span><br />
                                <span> Contacto: +56912345678</span><br />
                                <span> Precio: $100.000</span>
                            </Card.Text>
                            <Button variant="primary">Pedir</Button>
                        </Card.Body>
                    </Card>
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="https://mdbootstrap.com/img/Photos/Slides/img%20(2).jpg" />
                        <Card.Body>
                            <Card.Title>Paisaje N°2</Card.Title>
                            <Card.Text>
                                <span> Nombre: Pedro</span><br />
                                <span> Contacto: +56912345678</span><br />
                                <span> Precio: $300.000</span>
                            </Card.Text>
                            <Button variant="primary">Pedir</Button>
                        </Card.Body>
                    </Card>
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="https://mdbootstrap.com/img/Photos/Slides/img%20(3).jpg" />
                        <Card.Body>
                            <Card.Title>Paisaje N°3</Card.Title>
                            <Card.Text>
                                <span> Nombre: Alan</span><br />
                                <span> Contacto: +56912345678</span><br />
                                <span> Precio: $200.000</span>
                            </Card.Text>
                            <Button variant="primary">Pedir</Button>
                        </Card.Body>
                    </Card>
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="https://mdbootstrap.com/img/Photos/Slides/img%20(4).jpg" />
                        <Card.Body>
                            <Card.Title>Paisaje N°4</Card.Title>
                            <Card.Text>
                                <span> Nombre: Vito</span><br />
                                <span> Contacto: +56912345678</span><br />
                                <span> Precio: $150.000</span>
                            </Card.Text>
                            <Button variant="primary">Pedir</Button>
                        </Card.Body>
                    </Card>
                </Row>
            </div>
        </div>
    );
}

export default Home;

