import plant from "../images/plant.png";
import "../index.css";

function Logo() {
  return (
    <div>
      <div className="logo">
        <img className="logo_img" src={plant} alt="Plant" />
      </div>
    </div>
  );
}

export default Logo;
