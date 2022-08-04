import Header from "../UI/Header/Header";
import { Route, Routes } from "react-router-dom";
import ListaDeCompras from "../Compras/ListaDeCompras/ListaDeCompras";
const HomeScreen = () => {
  return (
    <div>
      <Header />
      <Routes>
        <Route path="lista-de-compras" element={<ListaDeCompras />}></Route>
      </Routes>
    </div>
  );
};

export default HomeScreen;
