import "./Card.css";

const Card = (props) => {
  const dataCompradaStr = props.character.dataQuandoFoiComprada;
  const dataComprada = new Date(dataCompradaStr);
  return (
    <div className="Card">
      <p>Nome: {props.character.nome}</p>
      <p>Valor: {props.character.valor}</p>
      <p>
        Data:{" "}
        {dataComprada.getDay().toString() +
          "/" +
          dataComprada.getMonth().toString() +
          "/" +
          dataComprada.getFullYear().toString()}
      </p>
    </div>
  );
};

export default Card;
