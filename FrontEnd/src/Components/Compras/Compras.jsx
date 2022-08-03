import { useState } from "react";
import Card from "./Card";
import "./Compras.css";
import Button from "react-bootstrap/Button";
import { useQuery } from "@tanstack/react-query";
import HeaderMenu from "../Header/Header";

const MovieData = (props) => {
  const [compras, setCompras] = useState([]);
  const fetchData = () =>
    fetch("https://localhost:44309/compras").then((response) =>
      response.json()
    );
  const { status, data, error } = useQuery(["compras"], fetchData);
  if (status === "loading") {
    return <h1>Loading...</h1>;
  }
  if (status === "error") {
    return <h1>Error!: {error.message}</h1>;
  }
  const recuperarComprasHandler = () => {
    console.log(data);
    setCompras(data);
  };

  return (
    <HeaderMenu>
      <div className="Button-Loader">
        <Button className="primary" onClick={recuperarComprasHandler}>
          Load All Data...
        </Button>
      </div>
      <div className="Cards">
        {compras.map((character, index) => (
          <Card character={character} key={index} />
        ))}
      </div>
    </HeaderMenu>
  );
};

export default MovieData;
