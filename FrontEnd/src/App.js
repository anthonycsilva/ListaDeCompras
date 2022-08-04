import "./App.css";
import React from "react";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import Compras from "./Components/Compras/Compras";
function App() {
  const queryClient = new QueryClient();
  return (
    <QueryClientProvider client={queryClient}>
      <div className="Main">
        <Compras />
      </div>
    </QueryClientProvider>
  );
}
export default App;
