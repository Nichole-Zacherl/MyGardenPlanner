function Remaining() {
  return (
    <div style={{ color: "black" }}>
      <h2>To do's</h2>
      <li>create BE model/table/controller/ect.</li>
      <li>display plant list</li>
      <li> Add new button</li>
      <li>edit to side of list items</li>
      <div style={{ display: "flex" }}>
        <div className="Create">
          <h3>create</h3>
          <div style={{ textAlign: "left" }}>
            <li>input items</li>
            <li>save button</li>
          </div>
        </div>
        <div className="Edit">
          <h3>edit</h3>
          <div style={{ textAlign: "left" }}>
            <li>displays exsisting inputs</li>
            <li>save button</li>
            <li>delete - archive? button</li>
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

function IssuesPage() {
  return (
    <div className="container">
      <div className="container-base">
        <h1>Issues (Ailment) Page</h1>
        <Remaining />
      </div>
    </div>
  );
}

export default IssuesPage;
