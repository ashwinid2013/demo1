import { Link, Outlet } from "react-router-dom";
function ParentComponent(){
    return(<div>
        <h1>Welcome to Parent Home</h1>
        
        <div className="App">
            <nav className='navbar navbar-expand-sm bg-light mb-3'>
                <div className='container-fluid'>
                    <ul className='navbar-nav'>
                        <li className='nav-item'>
                            <Link to="viewMarks" className='"nav-link px-3'>View Marks</Link>
                        </li>
                    
                        <li className='nav-item'>
                            <Link to="viewAssignment" className='"nav-link px-3'>View Assignment</Link>
                        </li>

                        <li className='nav-item'>
                            <Link to="viewTeachers Details" className='"nav-link px-3'>View Teacher</Link>
                        </li>

                        <li className='nav-item'>
                            <Link to="/logout" className='"nav-link px-3'>Logout</Link>
                        </li>


                    </ul>
                </div>
            </nav>
            <Outlet/>
        </div>

    </div>)
}
export default ParentComponent;



