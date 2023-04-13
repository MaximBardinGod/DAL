const Contacts = () => {
    return (
		<main className="section">
			<div className="container">
				<h1 className="title-1">Оффлайн запись</h1>

				<ul className="content-list">
					<li className="content-list__item">
						<h2 className="title-2">Местонахождение</h2>
						<p>Рязань, Россия</p>
					</li>
					<li className="content-list__item">
						<h2 className="title-2">Telegram / WhatsApp</h2>
						<p>
							<a href="tel:+79051234567">+7 (952) 122-04-23</a>
						</p>
					</li>
					<li className="content-list__item">
						<h2 className="title-2">Email</h2>
						<p>
							<a href="mailto:bmaximss2003@gmail.com">
								bmaximss2003@gmail.com
							</a>
						</p>
					</li>
				</ul>
			</div>
		</main>
	);
}

export default Contacts;