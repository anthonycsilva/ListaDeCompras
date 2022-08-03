import { useState } from "react";
import Card from "./Card";
import "./UsingReactQueryComponent.css";
import Button from "react-bootstrap/Button";
import { useQuery } from "@tanstack/react-query";

const MovieData = (props) => {
  const [characters, setCharacters] = useState([]);
  const fetchData = () =>
    fetch("https://rickandmortyapi.com/api/character").then((response) =>
      response.json()
    );
  const { status, data, error } = useQuery(["rickMortyData"], fetchData);
  if (status === "loading") {
    return <h1>Loading...</h1>;
  }
  if (status === "error") {
    return <h1>Error!: {error.message}</h1>;
  }
  const fetchRickMortyDataHanlder = () => {
    setCharacters(data.results);
  };

  return (
    <div>
      <div className="Button-Loader">
        <Button className="primary" onClick={fetchRickMortyDataHanlder}>
          Load All Data...
        </Button>
      </div>
      <div className="Cards">
        {characters.map((character, index) => (
          <Card character={character} key={index} />
        ))}
      </div>
    </div>
  );
};

export default MovieData;
