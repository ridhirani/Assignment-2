// import logo from './logo.svg';
import './App.css';
//import React,{useEffect, useState} from 'react';
// import {Button, Badge} from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import SaleData from './Components/SaleData';
// import {Container,Button,Alert} from 'react-bootsrap';
import React,{useEffect} from 'react'
import { Button } from 'bootstrap';
import Submit from './Components/SaleData';
import { BrowserRouter, Route, Switch, NavLink } from 'react-router-dom';
// import Submit from './Components/SaleData';


function App() {
  fetch("https://localhost:44398/api/Sales")
  .then((res)=>{res.json().then((res)=>{
    console.warn("result",res)
  })})
return (
  <BrowserRouter>
      <div className="App container">
        <h3 className="d-flex justify-content-center m-3">
          My React App
        </h3>
        <nav className="navbar navbar-expand-sm bg-light navbar-dark">
          <ul className="navbar-nav">
            <li className="nav-item m-1">
              <NavLink className="btn btn-light btn-outline-primary" to="/update">
                Edit
              </NavLink>
            </li>
          
          </ul>
        </nav>

        <switch>
          
          <Route path='/Update' component={Submit}></Route>
        </switch>
      </div>
    </BrowserRouter>
  );
}
export default App;

