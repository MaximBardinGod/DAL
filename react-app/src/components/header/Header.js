import "./style.css";

const Header = () => {
    return (
		<header className="header">
			<div className="header__wrapper">
				<h1 className="header__title">
					<strong>
						Выбирай <em>спорт</em>
					</strong>
				</h1>
				<div className="header__text">
					<p>С нами ты получишь результат</p>
				</div>
			</div>
		</header>
	);
}

export default Header;