import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Navbar from 'react-bootstrap/Navbar';
import Nav from 'react-bootstrap/Nav';
import NavDropdown from 'react-bootstrap/NavDropdown';
import Image from 'react-bootstrap/Image'
import Col from "react-bootstrap/Col";
import Row from "react-bootstrap/Row";
import Container from "react-bootstrap/Container";
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link,
  Redirect
} from "react-router-dom";
import Users from './Users/Users';
import Servicios from './Servicios/Servicios';
import Registrar from './Registrar/Registrar';
import Home from './Home/Home';
import Card from "react-bootstrap/Card";
import Button from "react-bootstrap/Button";
import React from "react";

function App() {
  return (
    <div className="App">
      <Router>
        <div>
          <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">
            <Navbar.Brand><Link to="/"><div style={{color:"rgba(255,255,255,.5)", textDecoration:'none'}}>Home</div></Link></Navbar.Brand>
            <Navbar.Toggle aria-controls="responsive-navbar-nav" />
            <Navbar.Collapse id="responsive-navbar-nav">
              <Nav className="mr-auto">
                <Nav.Link><Link to="/Users/Users"><div style={{color:"rgba(255,255,255,.5)", textDecoration:'none'}}>Users</div></Link></Nav.Link>
                <Nav.Link><Link to="/Servicios/Servicios"><div style={{color:"rgba(255,255,255,.5)", textDecoration:'none'}}>Servicio</div></Link></Nav.Link>
                <Nav.Link><Link to="/Registrar/Registrar"><div style={{color:"rgba(255,255,255,.5)", textDecoration:'none'}}>Registrar</div></Link></Nav.Link>
              </Nav>
              <Nav>
                <Nav.Link href="#deets">
                  <Container>
                    <Row>
                      <Col xs={6} md={4}>
                        <Image width={'50em'} src="https://mdbootstrap.com/img/Photos/Avatars/avatar-1.jpg" roundedCircle />
                      </Col>
                    </Row>
                  </Container>
                </Nav.Link>
              </Nav>
            </Navbar.Collapse>
          </Navbar>
          <Switch>
            <Route exact path="/" component={Home}/>
            <Route exact path="/Users/Users" component={Users} />
            <Route exact path="/Servicios/Servicios" component={Servicios} />
            <Route exact path="/Registrar/Registrar" component={Registrar} />
          </Switch>
        </div>
      </Router>
    </div>
  );
}

export default App;
