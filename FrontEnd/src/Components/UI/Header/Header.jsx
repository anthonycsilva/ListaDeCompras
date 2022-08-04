import Container from "react-bootstrap/Container";
import Nav from "react-bootstrap/Nav";
import Navbar from "react-bootstrap/Navbar";
import { Link } from "react-router-dom";

function HeaderMenu(props) {
  return (
    <>
      <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">
        <Container>
          <Link to="/lista-de-compras">
            <Navbar.Brand>Lista de Compras</Navbar.Brand>
          </Link>
          <Navbar.Toggle aria-controls="responsive-navbar-nav" />
          <Navbar.Collapse id="responsive-navbar-nav">
            <Nav className="me-auto">
              <Link to="/lista-de-compras">
                <Nav.Link href="lista-de-compras">Compras</Nav.Link>
              </Link>
              <Link to="/usuario/conta">
                <Nav.Link href="conta">Conta</Nav.Link>
              </Link>
            </Nav>
            <Nav>
              <Link to="/usuario/cadastrar">
                <Nav.Link href="#">Cadastrar</Nav.Link>
              </Link>
              <Link to="/usuario/sair">
                <Nav.Link href="#">Sair</Nav.Link>
              </Link>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
      {props.children}
    </>
  );
}

export default HeaderMenu;
