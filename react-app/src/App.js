import "./styles/main.css";

import {BrowserRouter as Router, Routes, Route} from "react-router-dom";

import Navbar from "./components/navbar/Navbar"
import Footer from "./components/footer/Footer";
import Home from "./pages/Home";
import Subscription from "./pages/Subscription";
import Contacts from "./pages/Contacts";
import { FormRegister } from "./components/form/FormRegister";


function App() {
  return (
		<div className="App">
			<Router>
				<Navbar />
				<Routes>
					<Route path="/" element={<Home />} />
					<Route path="/subscription" element={<Subscription />} />
					<Route path="/contacts" element={<Contacts />} />
					<Route path="/register" element={<FormRegister />} />
				</Routes>
				<Footer />
			</Router>
		</div>
  );
}

export default App;
