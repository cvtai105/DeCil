import React from 'react';

const Navbar = () => {
  return (
    <div className="flex items-center justify-between p-4 bg-white shadow-md">
      <div className="flex items-center space-x-4">
        <button className="text-xl">&#9776;</button>
        <span className="text-lg font-semibold">Constructor</span>
        <div className="flex space-x-4 ml-4">
          <a href="/dashboard" className="text-gray-600 hover:underline">Dashboard</a>
          <a href="/about-us" className="text-gray-600 hover:underline">About Us</a>
          <a href="/news" className="text-gray-600 hover:underline">News</a>
          <a href="/user-policy" className="text-gray-600 hover:underline">User Policy</a>
          <a href="/contacts" className="text-gray-600 hover:underline">Contacts</a>
          <a href="/more" className="text-gray-600 hover:underline">...</a>
        </div>
      </div>
      <div className="flex-grow mx-4">
        <input
          type="text"
          className="w-full max-w-md px-4 py-2 border rounded-full focus:outline-none focus:ring focus:border-blue-300"
          placeholder="Search Transactions and Documents"
        />
      </div>
      <div className="flex items-center space-x-4">
        <div className="flex items-center space-x-2">
          <div className="w-8 h-8 bg-gray-300 rounded-full"></div>
          <span>Clayton Santos</span>
        </div>
        <button className="relative">
          <span className="absolute top-0 right-0 w-2.5 h-2.5 bg-pink-600 rounded-full"></span>
          <svg className="w-6 h-6 text-gray-600" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
            <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M15 17h5l-1.405-1.405A2.032 2.032 0 0118 14.158V11a6.002 6.002 0 00-4-5.659V5a2 2 0 10-4 0v.341C7.67 6.165 6 8.388 6 11v3.159c0 .538-.214 1.055-.595 1.436L4 17h5m4 0v2a2 2 0 11-4 0v-2m4 0H9"></path>
          </svg>
        </button>
        <button>
          <svg className="w-6 h-6 text-gray-600" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
            <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M6 18L18 6M6 6l12 12"></path>
          </svg>
        </button>
      </div>
    </div>
  );
};

export default Navbar;
