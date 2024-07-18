import React, {useState} from 'react';
import renderMoney from '../utils/renderMoney';
import useFetch from '../hooks/useFetch';
import ToolbarButton from '../components/ToolbarButton';
import { faSearch, faFilter } from '@fortawesome/free-solid-svg-icons';

const apiHost = process.env.REACT_APP_API_HOST;


const DashBoard = ({platformCss, platformName}) => {
  const {data: products, loading, error} = useFetch(`${apiHost}/api/products`);

  return (
    <>
      <div className='flex justify-between'>
        <h2>Product</h2>
        <div className="flex bg-white border border-gray-200 rounded-lg shadow-sm">
          <ToolbarButton
            icon={
              <faFilter/>
            }
            text="Filtres"
          />
          <ToolbarButton
            icon={
              <svg className="w-5 h-5 text-gray-500" fill="none" stroke="currentColor" strokeWidth="2" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                <path strokeLinecap="round" strokeLinejoin="round" d="M21 21l-6-6m3-3a8 8 0 11-11.314 0 8 8 0 0111.314 0z"></path>
              </svg>
            }
            text="Search"
          />
          <ToolbarButton
            icon={
              <svg className="w-5 h-5 text-gray-500" fill="none" stroke="currentColor" strokeWidth="2" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                <path strokeLinecap="round" strokeLinejoin="round" d="M15.232 5.232l1.536 1.536a1 1 0 010 1.414l-1.536 1.536m-4.146 9.182H4.96a2.293 2.293 0 01-2.293-2.293v-7.5a2.293 2.293 0 012.293-2.293h7.5a2.293 2.293 0 012.293 2.293v7.5a2.293 2.293 0 01-2.293 2.293zm3.086-7.071l-9.464 9.464M21 11a8.973 8.973 0 00-2.293-6.207M5.964 5.964l1.414-1.414"></path>
              </svg>
            }
            text="Edit"
          />
          <ToolbarButton
            icon={
              <svg className="w-5 h-5 text-gray-500" fill="none" stroke="currentColor" strokeWidth="2" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                <path strokeLinecap="round" strokeLinejoin="round" d="M8 6h8M6 6h2m8 0h2M8 10h8m-8 4h8m-8 4h8m-8-2h2m8-2h2M6 10h2m2 4h4m4-4h2m-6 4h2M6 14h2"></path>
              </svg>
            }
            text="Delete"
          />
        </div>
        <button className="flex items-center bg-purple-500 hover:bg-purple-700 text-white font-bold  pl-4 pr-6 rounded-full shadow-lg focus:outline-none focus:shadow-outline transition duration-300 ease-in-out">
          <span className="bg-inherit rounded-full px-2 mr-2">
            <svg className="w-4 h-4 text-white" fill="none" stroke="currentColor" strokeWidth="2" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
              <path strokeLinecap="round" strokeLinejoin="round" d="M12 4v16m8-8H4"></path>
            </svg>
          </span>
          <span>
            Add Product
          </span>
        </button>
      </div>
    </>
    
  );
};

export default DashBoard;
