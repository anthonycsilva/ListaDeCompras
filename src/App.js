import "./App.css";
import React from "react";
import UsingReactQueryComponent from "./Components/UsingReactQueryComponent/UsingReactQueryComponent";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
function App() {
  const queryClient = new QueryClient();
  return (
    <QueryClientProvider client={queryClient}>
      <div className="Main">
        <UsingReactQueryComponent />
      </div>
    </QueryClientProvider>
  );
}
export default App;
