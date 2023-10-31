function Remaining() {
  return (
    <div style={{ color: "black" }}>
      <h2>To do's</h2>
      <li>create new garden or edit exsisting</li>
      <div style={{ display: "flex" }}>
        <div className="Create">
          <h3>create</h3>
          <div style={{ textAlign: "left" }}>
            <li>select garden type</li>
            <li>enter in specs</li>
            <li>displays mock garden template</li>
            <li>plant list to the side</li>
            <li>notes section?</li>
            <li>warning colors for plants that are compatable/not</li>
          </div>
        </div>
        <div className="Edit">
          <h3>edit</h3>
          <div style={{ textAlign: "left" }}>
            <li>displays exsisting mock garden template</li>
          </div>
        </div>
      </div>
      <div>
        <li>create dummy data</li>
        <li>test</li>
      </div>
    </div>
  );
}

function PlantPage() {
  return (
    <div className="container">
      <div className="container-base">
        <h1>Plant Page</h1>
        <Remaining />
      </div>
    </div>
  );
}

export default PlantPage;
