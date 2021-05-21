import React from 'react';
import ReactDOM from 'react-dom';

class EmployeeComponent extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      employees: []
    };
  }
  componentDidMount() {
    fetch("http://localhost:1506/api/Employee").then(res => res.json()).then(
        result=>{
          this.setState({employees:result});
        }
      );
  }
  render() {
    return (
      <div>
        <h2>Employees Data...</h2>
        <table>
          <thead>
            <tr>
              <th> Id </th>
              <th> Name </th>
              <th> Location </th>
              <th> Salary </th>
            </tr>
          </thead>
          <tbody>  
          {this.state.employees.map(emp => (
            <tr key={emp.Id}>
              <td>{emp.Id}</td>
              <td>{emp.name}</td>
              <td>{emp.location}</td>
              <td>{emp.salary}</td>
              </tr>
            ))}       
          </tbody>
        </table>
      </div>
      );
    }
}

const element=<EmployeeComponent></EmployeeComponent>

ReactDOM.render(element,document.getElementById("root"));