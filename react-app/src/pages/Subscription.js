import React, { Component, useEffect, useState } from "react";

export default class Subscription extends Component {
  constructor(props) {
    super(props);
    this.state = {
      isLoaded: false,
      items: [],
    };
  }

  componentDidMount() {
    fetch("/api/Domain/Product")
      .then((res) => res.json())
      .then(({ items }) => {
        this.setState({
          isLoaded: true,
          items,
        });
      });
  }

  render() {
    var { isLoaded, items } = this.state;
    if (!isLoaded) return <div>Loading...</div>;
    return (
      <div>
        <ul>
          {items.map(({ productId, statistics }) => (
            <li key={productId}>Total views: {statistics.name}</li>
          ))}
        </ul>
      </div>
    );
  }
}
