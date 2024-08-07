import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { NavLink, Route, Routes } from 'react-router-dom';
import LoginComponent from './components/login';
import ParentComponent from './components/Parent';
import AdminComponent from './components/Admin';
import TeacherComponent from './components/Teacher';
import { useSelector } from 'react-redux';
import LogoutComp from './components/LogoutComp';
import AddUser2 from './components/Adduser2';
import ContactUs from './components/ContactUS';
import AddSubject from './components/AddSubject';

function App() {
  const mystate = useSelector((state) => state.logged);
         
 

  return (
    <div className="App">
      <header className="app-header bg-primary text-white p-3 d-flex justify-content-between align-items-center">
        <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1gwaIP7z8rY_XxsMkCd991jeKdmDJmPJ2cq2MvAa40jGQH-CZDBUwfKvffPVJYIXlO0o&usqp=CAU" width={100} height={100} alt='logo' />
        {!mystate.loggedIn && (
          <nav className='d-flex'>
            <ul className='navbar-nav flex-row'>
              
              <li className='nav-item'>
                <NavLink to="/" className="nav-link px-3" activeClassName="active">Home</NavLink>
              </li>
              
              <li className='nav-item'>
                <NavLink to="/contact" className="nav-link px-3" activeClassName="active">Contact Us</NavLink>
              </li>

              <li className='nav-item'>
                <NavLink to="/login" className="nav-link px-3" activeClassName="active">Login</NavLink>
              </li>
            </ul>
          </nav>
        )}
      </header>
     

      <Routes>
        <Route path="/" element={<HomeComponent />} />
        <Route path="/login" element={<LoginComponent />} />
        <Route path="/Admin_home" element={<AdminComponent />}>
          <Route path="AddUser" element={<AddUser2 />} />
          <Route path="AddSubject"element={<AddSubject/>}/>
        </Route>
        <Route path="/Teacher_home" element={<TeacherComponent />} />
        <Route path="/Parent_home" element={<ParentComponent />} />
        <Route path="/logout" element={<LogoutComp />} />
        <Route path="/contact" element={<ContactUs />} />
      </Routes>
    </div>
  );
}


function HomeComponent() {
  
  return(<div>
  <h1 className=' text-blue text-center'>Welcome to the EduConnect</h1>
</div>);
}

export default App;
