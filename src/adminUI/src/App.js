import {
  createBrowserRouter,
  createRoutesFromElements,
  RouterProvider,
  Route
} from "react-router-dom";
import * as React from "react";
import * as ReactDOM from "react-dom/client";

const routes = createRoutesFromElements(
  <>
    <Route path="/" element={<></> } >
    </Route>

    <Route path="/nhanvien" element={<></>} >
    </Route>

    <Route path="/doanhnghiep" element={ <></>}>
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
