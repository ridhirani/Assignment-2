import React, { Component } from 'react';
import { variables } from './Variables.js';

export class Submit extends Component {
  constructor(props) {
    super(props);
    this.state = {
      sales: [],
      saleId: '',
      SalesOpportunitySoname: '',
      Buname: '',
      SoRegionId: '',
      SalesOpportunityBusname: '',
      SalesOpportunityDivname: '',
      SoMarketId: '',
      PrjtType: '',
      JobType: '',
      SowName: '',
      PriDollarAmt: '',
      SoNumSites: '',
      UspGetSalesOpportunityData: '',
      Phase: '',
      PhsPrc: '',
      SalesOpportunityWeightedAmount: '',
      SalesOpportunityActiveSalesEmployee: '',
      SalesOpportunitySoPhaseStartDate: '',
      SalesOpportunitySalesEmployee: '',
      SalesOpprotunityManager: '',
      SalesOpportunitySoStartDate: '',
      SalesOpportunitySoClosingDate: '',
      SalesOpportunitySoEndDate: '',
      SalesOpportunitySloEstWorkDate: '',
      Intlevel: '',
      SosStatus: '',
      SosReason: '',
    }
  }
  

  editClick(dep) {
    this.setState({
      modalTitle: "Edit Department",
      DepartmentId: dep.DepartmentId,
      DepartmentName: dep.DepartmentName
    });
  }


  updateClick() {
    fetch(variables.API_URL + 'Sales/Update', {
      method: 'PUT',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
        saleId: this.state.saleId,
        SalesOpportunitySoname: this.state.SalesOpportunitySoname,
        Buname: this.state.Buname,
        SoRegionId: this.state.SoRegionId,
        SalesOpportunityBusname: this.state.SalesOpportunityBusname,
        SalesOpportunityDivname: this.state.SalesOpportunityDivname,
        SoMarketId: this.state.SoMarketId,
        PrjtType: this.state.PrjtType,
        JobType: this.state.JobType,
        SowName: this.state.SowName,
        PriDollarAmt: this.state.PriDollarAmt,
        SoNumSites: this.state.SoNumSites,
        UspGetSalesOpportunityData: this.state.UspGetSalesOpportunityData,
        Phase: this.state.Phase,
        PhsPrc: this.state.PhsPrc,
        SalesOpportunityWeightedAmount: this.state.SalesOpportunityWeightedAmount,
        SalesOpportunityActiveSalesEmployee: this.state.SalesOpportunityActiveSalesEmployee,
        SalesOpportunitySoPhaseStartDate: this.state.SalesOpportunitySoPhaseStartDate,
        SalesOpportunitySalesEmployee: this.state.SalesOpportunitySalesEmployee,
        SalesOpprotunityManager: this.state.SalesOpprotunityManager,
        SalesOpportunitySoStartDate: this.state.SalesOpportunitySoStartDate,
        SalesOpportunitySoEndDate: this.state.SalesOpportunitySoEndDate,
        SalesOpportunitySoClosingDate: this.state.SalesOpportunitySoClosingDate,
        SalesOpportunitySloEstWorkDate: this.state.SalesOpportunitySloEstWorkDate,
        Intlevel: this.state.Intlevel,
        SosStatus: this.state.SosStatus,
        SosReason: this.state.SosReason
      })
    })
      .then(res => res.json())
      .then((result) => {
        alert(result);
        this.refreshList();
      }, (error) => {
        alert('Failed');
      })
  }
  //     const [inputField , setInputField] = useState({
  //         SaleId: '',
  //         SalesOpportunitySoname: '',
  //         gmaiBuname: '',
  //         SalesOpportunitySoname: '',
  //         SalesOpportunitySoname: '',
  //         SalesOpportunitySoname: '',
  //         SalesOpportunitySoname: '',
  //         SalesOpportunitySoname: '',
  //         SalesOpportunitySoname: '',
  //         SalesOpportunitySoname: '',
  //         SalesOpportunitySoname: '',
  //         SalesOpportunitySoname: '',
  // x

  //     })

  //     const inputsHandler = (e) =>{
  //         setInputField( {[e.target.name]: e.target.value} )
  //     }

  //     const submitButton = () =>{
  //         alert(inputField.first_name)
  //     }

  render() {
    const {
      saleId,
      SalesOpportunitySoname,
      Buname,
      SoRegionId,
      SalesOpportunityBusname,
      SalesOpportunityDivname,
      SoMarketId,
      PrjtType,
      JobType,
      SowName,
      PriDollarAmt,
      SoNumSites,
      UspGetSalesOpportunityData,
      Phase,
      PhsPrc,
      SalesOpportunityWeightedAmount,
      SalesOpportunityActiveSalesEmployee,
      SalesOpportunitySoPhaseStartDate,
      SalesOpportunitySalesEmployee,
      SalesOpprotunityManager,
      SalesOpportunitySoStartDate,
      SalesOpportunitySoClosingDate,
      SalesOpportunitySoEndDate,
      SalesOpportunitySloEstWorkDate,
      Intlevel,
      SosStatus,
      SosReason,

    } = this.state;
    return (

      <div>
        <button type="button"
          className="btn btn-primary m-2 float-end"
          data-bs-toggle="modal"
          data-bs-target="#exampleModal"
          onClick={() => this.addClick()}>
          Add Department
        </button>
        <table className="table table-striped">
          <thead>
            <tr>
              <th>
                Options
              </th>
            </tr>
          </thead>
          <tbody>
           
          </tbody>
        </table>
        <div className="modal fade" id="exampleModal" tabIndex="-1" aria-hidden="true">
          <div className="modal-dialog modal-lg modal-dialog-centered">
            <div className="modal-content">
             

              
             
            </div>
          </div>
        </div>
      </div>

      //             <input 
      //             type="text" 
      //             name="first_name" 
      //             onChange={inputsHandler} 
      //             placeholder="First Name" 
      //             value={inputField.first_name}/>

      //             <br/>

      //             <input 
      //             type="text" 
      //             name="last_name" 
      //             onChange={inputsHandler} 
      //             placeholder="First Name" 
      //             value={inputField.last_name}/>

      //             <br/>

      //             <input 
      //             type="gmail" 
      //             name="gmail" 
      //             onChange={inputsHandler} 
      //             placeholder="Gmail" 
      //             value={inputField.gmail}/>

      //             <br/>

      //             <button onClick={submitButton}>Submit Now</button>
      //         </div>
    )
  }
}

export default Submit
