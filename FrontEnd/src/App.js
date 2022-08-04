import "./App.css";
import React from "react";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import HeaderMenu from "./Components/UI/Header/Header";
import "bootstrap/dist/css/bootstrap.min.css";
function App() {
  const queryClient = new QueryClient();
  return (
    <QueryClientProvider client={queryClient}>
      <HeaderMenu></HeaderMenu>
    </QueryClientProvider>
  );
}
export default App;
