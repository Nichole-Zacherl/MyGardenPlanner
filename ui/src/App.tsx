import "./App.css";
import "./index.css";

import MyAppBar from "./components/MyAppBar";

import { BrowserRouter, Route, Routes } from "react-router-dom";

import HomePage from "./pages/Home";
import CreateGarden from "./pages/CreateGarden";
import PlantPage from "./pages/PlantPage";
import IssuesPage from "./pages/IssuesPage";

function App() {
  function Remaining() {
    return (
      <div className="container">
        <div className="container-base">
          <div>
            <h2>Project to do's</h2>
            <li>work on all page layouts</li>
            <li>connect to backend - server?</li>
            <li>after working CRUD - create dummy data</li>
            <li>stylize</li>
            <li>test</li>
          </div>
        </div>
      </div>
    );
  }

  function NotFound() {
    return (
      <>
        <h2 style={{ color: "black" }}>Uh oh.</h2>
        <p>
          The page you requested could not be found. Is there any chance you
          were looking for one of these?
        </p>
      </>
    );
  }

  return (
    <div>
      <div className="main">
        <div className="header">
          <BrowserRouter>
            <MyAppBar />
            <Routes>
              <Route path="/" element={<HomePage />} />
              <Route path="garden" element={<CreateGarden />} />
              <Route path="plants" element={<PlantPage />} />
              <Route path="ailments" element={<IssuesPage />} />
              <Route path="remains" element={<Remaining />} />
              <Route path="*" element={<NotFound />} />
            </Routes>
          </BrowserRouter>
        </div>
      </div>
    </div>
  );
}

export default App;
