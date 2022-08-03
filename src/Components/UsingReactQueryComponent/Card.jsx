import "./Card.css";

const Card = (props) => {
  return (
    <div className="Card">
      <img src={props.character.image} alt=""></img>
      <p>Name: {props.character.name}</p>
      <p>Status: {props.character.status}</p>
      <p>Gender: {props.character.gender}</p>
    </div>
  );
};

export default Card;
