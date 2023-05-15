import React, { Component, useEffect, useState } from "react";
import { Button } from "react-bootstrap";

export default function Subscription() {
  const [data, setData] = useState([]);

  useEffect(() => {
    fetch("/api/Domain/SubscriptionStyle")
      .then((res) => res.json())
      .then((res) => {
        setData(res);
      });
  }, []);

  return (
    <div>
      <h1>Subscription:</h1>
      {data.map((post) => {
        return (
          <div>
            <strong>
              {post.subscriptionStyleId}. {post.nameSubscription} - {post.cost}
            </strong>
            <div>
              {post.description}
              <Button style={{ marginLeft: 40 }}>Buy</Button>
            </div>
          </div>
        );
      })}
    </div>
  );
}
