import React, { useEffect, useState } from "react"

const Subscription = () => {

  const [sub, setSubs] = useState([])

  const fetchSubData = () => {
    fetch("https://jsonplaceholder.typicode.com/users")
      .then(response => {
        return response.json()
      })
      .then(data => {
        setSubs(data)
      })
  }

  useEffect(() => {
    fetchSubData()
  }, [])

  return (
    <main>
      <h1>Subscriptions</h1>
    </main>
  );
};

export default Subscription;
