import { NavLink } from 'react-router-dom';
import './style.css';

const Navbar = () => {
	const activeLink = 'nav-list__link nav-list__link--active';
	const normalLink = 'nav-list__link';

	return (
		<nav className="nav">
			<div className="container">
				<div className="nav-row">
					<NavLink to="/" className="logo">
						<strong>high </strong> growth
					</NavLink>

					<ul className="nav-list">
						<li className="nav-list__item">
							<NavLink
								to="/"
								className={({ isActive }) =>
									isActive ? activeLink : normalLink
								}
							>
								Home
							</NavLink>
						</li>

						<li className="nav-list__item">
							<NavLink
								to="/subscription"
								className={({ isActive }) =>
									isActive ? activeLink : normalLink
								}
							>
								Subscription
							</NavLink>
						</li>
						<li className="nav-list__item">
							<NavLink
								to="/contacts"
								className={({ isActive }) =>
									isActive ? activeLink : normalLink
								}
							>
								Contacts
							</NavLink>
						</li>
						<li className="nav-list__item">
							<NavLink
								to="/register"
								className={({ isActive }) =>
									isActive ? activeLink : normalLink
								}
							>
								Register
							</NavLink>
						</li>
						<li className="nav-list__item">
							<NavLink
								to="/product"
								className={({ isActive }) =>
									isActive ? activeLink : normalLink
								}
							>
								Product
							</NavLink>
						</li>
					</ul>
				</div>
			</div>
		</nav>
	);
};

export default Navbar;
