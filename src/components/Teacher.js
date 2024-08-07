import { NavLink, Outlet } from "react-router-dom";
function TeacherComponent(){
    return(<div>
        <h1>Welcome to Teacher Component</h1>

        <div className="App">
            <nav className='navbar navbar-expand-sm bg-light mb-3'>
                <div className='container-fluid'>
                    <ul className='navbar-nav'>
                        <li className='nav-item'>
                            <NavLink to="viewMarks" className='"nav-link px-3'>View Marks</NavLink>
                        </li>

                        <li className='nav-item'>
                            <NavLink to="addMarks" className='"nav-link px-3'>Add Marks</NavLink>
                        </li>
                    
                        <li className='nav-item'>
                            <NavLink to="Add Assignment" className='"nav-link px-3'>Add Assignment</NavLink>
                        </li>

                        <li className='nav-item'>
                            <NavLink to="View Student Details" className='"nav-link px-3'>View Student</NavLink>
                        </li>

                        <li className='nav-item'>
                            <NavLink to="/logout" className='"nav-link px-3'>Logout</NavLink>
                        </li>


                    </ul>
                </div>
            </nav>
            <Outlet />
        </div>


    </div>)
}
export default TeacherComponent;