import Header from './../components/header/Header'

const Home = () => {
    return (
		<>
			<Header />
			<main className="section">
				<div className="container">
					<ul className="content-list">
						<li className="content-list__item">
							<h2 className="title-2">Онлайн</h2>
							<p>
								Постоянный ментор
							</p>
							<p>
								Рацион питания
							</p>
							<p>
								Корректировка режима
							</p>
						</li>
						<li className="content-list__item">
							<h2 className="title-2">Оффлайн</h2>
							<p>
								Постоянный ментор
							</p>
							<p>
								Рацион питания
							</p>
							<p>
								Корректировка режима
							</p>
							<p>
								Тренажерный зал
							</p>
						</li>
					</ul>
				</div>
			</main>
		</>
	);
}

export default Home;