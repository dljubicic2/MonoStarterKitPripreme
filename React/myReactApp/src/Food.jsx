function Food(){
    const food1 = "hamburger";
    const food2 = "pancake";
    
    return(
        <ul>
            <li>Apple</li>
            <li>{food1}</li>
            <li>{food2.toUpperCase()}</li>
        </ul>
    );
}

export default Food