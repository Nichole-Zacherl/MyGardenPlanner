import { useState, useEffect } from "react";
import axios from "axios";
import "../utils/constant.ts";
import { API_HOST } from "../utils/constant.ts";

export type Garden = {
  id: string;
  name: string;
  description: string;
  length: number;
  width: number;
};

export const headers = {
  "Access-Control-Allow-Origin": API_HOST,
};

function GetGardenList() {
  const [items, setItems] = useState<Garden[]>([]);

  useEffect(() => {
    getGardens();
  }, []);

  const url = `${API_HOST}/api/garden/`;
  const getGardens = () => {
    axios
      .get(url, { headers })
      .then((res) => setItems(res.data))
      .catch((error) => {
        console.log("Error ========>", error);
      });
  };

  if (items.length == 0)
    return (
      <>
        <div> Loading...</div>
      </>
    );

  return (
    <div style={{ color: "black" }}>
      <h2>Gardens</h2>
      <div>
        {items != null ? (
          items.map((item) => (
            <div key={item.id} style={{ display: "flex" }}>
              <div style={{ margin: "5px" }}> {item.name} </div>
              <div style={{ margin: "5px" }}> {item.width} </div>
              <div style={{ margin: "5px" }}> {item.length} </div>
            </div>
          ))
        ) : (
          <div> Loading...</div>
        )}
      </div>
    </div>
  );
}

export default GetGardenList;
