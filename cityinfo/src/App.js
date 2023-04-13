import './App.css';
import HelloWorld from './components/HelloWorld';    
import Headers from './components/Headers';

function App() {
  return (
    <div className="App">
      <Headers nome = "home"/>
      <HelloWorld />
    </div>
  );
}

export default App;
