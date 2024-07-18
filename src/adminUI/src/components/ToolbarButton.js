import React from "react";

const ToolbarButton = ({ icon, text }) => {
return (
    <button className="flex items-center p-4 hover:bg-gray-100 transition duration-200 ease-in-out focus:outline-none">
    <span className="mr-2">{icon}</span>
    <span className="text-gray-600 font-semibold">{text}</span>
    </button>
);
};

export default ToolbarButton;