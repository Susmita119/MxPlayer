import React, {Component} from 'react'
import './MxPlayer.css'


class MxPlayer extends Component {

	constructor(props) {
		super (props)

		this.state = {
			songs: [
				{id:1,songName: 'Cold Water', Sequence: 1 },
			  	{id:2,songName: 'Attention', Sequence: 2 },
			  	{id:3, songName: 'Cheap Thrills', Sequence: 3 },
			  	{id:4,songName: 'Happier', Sequence: 4 },
			  	{id:5,songName: 'Better', Sequence: 5 }
			]
		}
	}

	renderTableHeader(){

		let header = Object.keys(this.state.songs[0])
		return header.map((key,index) =>{

			return<th key={index}>{key.toUpperCase()}</th>


		})

	}
  
  		renderTableData(){ 		

			return this.state.songs.map((song,index) => {
			const{id,songName} = song;
			return(

				<tr key={id}>
				<td>{id}</td>
				<td>{songName}</td>
				<td><button onClick={(e) => this.handleClick(song)}>save</button></td>
				</tr>
				)
		})

	}

	 handleClick = (e) => {
    console.log('this is:', e);
  	}


	 render () {
  	console.log (this.state.songs)
      return (

    <div>
     <button onClick={this.handleClick}>
        save
      </button>
      <h1 id='title'>React Dynamic Table</h1>
      <table id='songs'>
      <tbody>
      <tr>{this.renderTableHeader()}</tr>
      	{this.renderTableData()}
      </tbody>
      </table>
   </div>
    )
  }
}

export default MxPlayer
