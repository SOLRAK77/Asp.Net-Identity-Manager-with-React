import React from 'react';

const StudentDetails= props => (
    <div>
        {props.email && <p>Email: {props.email}</p>}
        {props.college && <p>College: {props.college}</p>}
    </div>
);
export default StudentDetails;