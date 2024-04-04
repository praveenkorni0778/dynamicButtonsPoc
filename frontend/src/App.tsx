import { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import { Buttons } from './Buttons';

function App() {
  const [formButtons, setFormButtons] = useState([]);
  useEffect(() => {
    axios.get(`https://localhost:7004/api/buttonscontroller/getbuttons/1/1`).then((res) => {
      setFormButtons(res.data);
      console.log(res);
    }).catch(() => {
      alert("Something went wrong....")
    })
  }, []);
  return (
    <div className="App">
      <form>
        <label htmlFor="fname">First name:</label><br />
        <input type="text" id="fname" name="fname" /><br />
        <label htmlFor="lname">Last name:</label><br />
        <input type="text" id="lname" name="lname" />
        {formButtons && <Buttons buttons={formButtons} />}
      </form>
    </div>
  );
}

export default App;
