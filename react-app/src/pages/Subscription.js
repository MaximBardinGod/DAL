import React, { Component, useEffect, useState } from "react"

export default class Subscription extends Component{

  constructor(props){
    super(props);
    this.state ={
      error:null,
      isLoaded:false,
      items:[]
    };
  }

  componentDidMount(){
    fetch("https://localhost:7028/api/Product")
    .then(res => res.json())
    .then(
      (result) =>{
        this.setState({
          isLoaded:true,
          items:result.products
        });
      },
      (error) =>{
        this.setState({
          isLoaded:true,
          error
        });
      }
    )
  }

  render(){
    const {error,isLoaded, items} = this.state;

    if (error){
      return <p> Error {error.message}</p>
    } else if(!isLoaded){
      return <p> Loading...</p>
    } else {
      return(
        <ul>
          {items.map(item =>(
            <li key={item.nameProd}>
              {item.countProtein}
            </li>
          ))}
        </ul>
      )
    }
  }

}