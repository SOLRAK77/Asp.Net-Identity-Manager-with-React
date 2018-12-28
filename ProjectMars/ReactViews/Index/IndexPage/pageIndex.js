import React from 'react';
import StudentDetails from '../IndexPageComponents/StudentDetails';

export default class Form extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            Email: undefined,
            College: undefined
        };
        fetch('api/Students')
            .then(api_call => api_call.json())
            .then(data => {
                console.log(data);
                this.setState({
                    Email: data[0].Email,
                    College: data[0].College
                });
            })
            .catch((error) => {
                console.log(error);
            });
    }
    render() {
        return (
            <div>
                <StudentDetails
                    email={this.state.Email}
                    college={this.state.College}
                />
            </div>
        );
    }
};