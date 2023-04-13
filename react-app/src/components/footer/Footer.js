import "./style.css";

import vk from "./../../img/vk.svg";
import instagram from "./../../img/instagram.svg";
import gitHub from "./../../img/gitHub.svg";

const Footer = () => {
  return (
    <footer className="footer">
      <div className="container">
        <div className="footer__wrapper">
          <ul className="social">
            <li className="social__item">
              <a href="https://vk.com/moyblagoslovlennyykloun">
                <img src={vk} alt="Link" />
              </a>
            </li>
            <li className="social__item">
              <a href="#!">
                <img src={instagram} alt="Link" />
              </a>
            </li>
            <li className="social__item">
              <a href="https://github.com/MaximBardinGod">
                <img src={gitHub} alt="Link" />
              </a>
            </li>
          </ul>
          <div className="copyright">
            <p>© 2023 HighGrowth.com</p>
          </div>
        </div>
      </div>
    </footer>
  );
};

export default Footer;
