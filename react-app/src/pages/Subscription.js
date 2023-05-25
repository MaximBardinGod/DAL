import React, { useEffect, useState } from "react";
import { Button } from "react-bootstrap";
import "../styles/main.css";

export default function Subscription() {
  const [data, setData] = useState([]);

  const fetchData = async () => {
    try {
      const res = await axios.get('/api/Domain/SubscriptionStyle');
      setData(res.data);
    } catch (error) {
      console.error(error);
    }
  };
  
  useEffect(() => {
    fetchData();
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
