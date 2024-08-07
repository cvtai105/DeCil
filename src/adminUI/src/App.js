import {
  createBrowserRouter,
  createRoutesFromElements,
  RouterProvider,
  Route
} from "react-router-dom";
import * as React from "react";
import * as ReactDOM from "react-dom/client";
import Main from "./layouts/Main";
import DashBoard from "./pages/Dashboard";


const routes = createRoutesFromElements(
  <>
    <Route path="/" element={<><Main></Main></> }>
      <Route path="/" element={<DashBoard/>} />
    </Route>

    <Route path="*" element={<div>Not Found</div>} />
  </>
);

const router = createBrowserRouter(routes);

function App() {

  return (
    <>
      <RouterProvider router={router} />
    </>
    
  );
}

export default App;
