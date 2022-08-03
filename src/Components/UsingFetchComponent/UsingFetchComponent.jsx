import { useState } from "react";
import Card from "./Card";
import "./UsingFetchComponent.css";
import Button from "react-bootstrap/Button";
const MovieData = (props) => {
  const [characters, setCharacters] = useState([]);
  const fetchRickMortyHanlder = async () => {
    const response = await fetch("https://rickandmortyapi.com/api/character");
    const data = await response.json();
    setCharacters(data.results);
  };
  console.log(characters);
  return (
    <div>
      <div className="Button-Loader">
        <Button className="primary" onClick={fetchRickMortyHanlder}>
          Load...
        </Button>
      </div>
      <div className="Cards">
        {characters.map((character) => (
          <Card character={character} />
        ))}
      </div>
    </div>
  );
};

export default MovieData;
